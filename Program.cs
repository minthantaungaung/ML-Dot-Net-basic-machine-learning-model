// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
//Load sample data
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = @"Crust is not bad.",
};

//Load model and predict output
var result = SentimentModel.Predict(sampleData);
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}"); 