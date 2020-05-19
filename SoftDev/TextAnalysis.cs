using System.Collections.Generic;
using Newtonsoft.Json;

public class TextAnalysis
{
    [JsonProperty("text")]
    public string Text;
    [JsonProperty("word_count")]
    public int WordCount;
    [JsonProperty("mean_word_length")]
    public double MeanWordLength;
    [JsonProperty("unique_letters")]
    public List<char> UniqueLetters;
    [JsonProperty("word_frequencies")]
    public Dictionary<string, int> WordFrequencies;

    public TextAnalysis() { }

    public TextAnalysis(string Text, int WordCount, double MeanWordLength, List<char> UniqueLetters, Dictionary<string, int> WordFrequencies)
    {
        this.Text = Text;
        this.WordCount = WordCount;
        this.MeanWordLength = MeanWordLength;
        this.UniqueLetters = UniqueLetters;
        this.WordFrequencies = WordFrequencies;
    }
}