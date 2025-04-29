using System;

namespace YSA_OCR__7x5
{
    public class NeuralNetwork
    {
        private int inputSize;
        private int hiddenSize;
        private int outputSize;
        private double learningRate;

        private double[] inputLayer;
        private double[] hiddenLayer;
        private double[] outputLayer;

        private double[,] weightsInputHidden;
        private double[,] weightsHiddenOutput;

        private Random rand = new Random();

        public NeuralNetwork(int inputSize, int hiddenSize, int outputSize, double learningRate)
        {
            this.inputSize = inputSize;
            this.hiddenSize = hiddenSize;
            this.outputSize = outputSize;
            this.learningRate = learningRate;

            inputLayer = new double[inputSize];
            hiddenLayer = new double[hiddenSize];
            outputLayer = new double[outputSize];

            weightsInputHidden = new double[inputSize, hiddenSize];
            weightsHiddenOutput = new double[hiddenSize, outputSize];

            InitializeWeights();
        }

        private void InitializeWeights()
        {
            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < hiddenSize; j++)
                    weightsInputHidden[i, j] = rand.NextDouble() * 2 - 1;

            for (int i = 0; i < hiddenSize; i++)
                for (int j = 0; j < outputSize; j++)
                    weightsHiddenOutput[i, j] = rand.NextDouble() * 2 - 1;
        }

        private double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        private double SigmoidDerivative(double x)
        {
            return x * (1 - x); // çıktı üzerinden türev
        }

        public double[] Predict(double[] inputs)
        {
            inputLayer = inputs;

            // Giriş -> Gizli
            for (int j = 0; j < hiddenSize; j++)
            {
                double sum = 0;
                for (int i = 0; i < inputSize; i++)
                    sum += inputLayer[i] * weightsInputHidden[i, j];
                hiddenLayer[j] = Sigmoid(sum);
            }

            // Gizli -> Çıkış
            for (int k = 0; k < outputSize; k++)
            {
                double sum = 0;
                for (int j = 0; j < hiddenSize; j++)
                    sum += hiddenLayer[j] * weightsHiddenOutput[j, k];
                outputLayer[k] = Sigmoid(sum);
            }

            return outputLayer;
        }

        public double Train(double[] inputs, double[] targets)
        {
            double[] outputs = Predict(inputs);

            // Çıkış katmanı hataları
            double[] outputErrors = new double[outputSize];
            for (int k = 0; k < outputSize; k++)
                outputErrors[k] = targets[k] - outputs[k];

            // Gizli katman hataları
            double[] hiddenErrors = new double[hiddenSize];
            for (int j = 0; j < hiddenSize; j++)
            {
                double error = 0;
                for (int k = 0; k < outputSize; k++)
                    error += outputErrors[k] * weightsHiddenOutput[j, k];
                hiddenErrors[j] = error;
            }

            // Gizli -> Çıkış ağırlıkları güncelle
            for (int j = 0; j < hiddenSize; j++)
            {
                for (int k = 0; k < outputSize; k++)
                {
                    double delta = outputErrors[k] * SigmoidDerivative(outputs[k]) * hiddenLayer[j];
                    weightsHiddenOutput[j, k] += learningRate * delta;
                }
            }

            // Giriş -> Gizli ağırlıkları güncelle
            for (int i = 0; i < inputSize; i++)
            {
                for (int j = 0; j < hiddenSize; j++)
                {
                    double delta = hiddenErrors[j] * SigmoidDerivative(hiddenLayer[j]) * inputLayer[i];
                    weightsInputHidden[i, j] += learningRate * delta;
                }
            }

            // Ortalama karesel hata (MSE)
            double totalError = 0;
            for (int k = 0; k < outputSize; k++)
                totalError += Math.Pow(outputErrors[k], 2);

            return totalError / outputSize;
        }
    }
}
