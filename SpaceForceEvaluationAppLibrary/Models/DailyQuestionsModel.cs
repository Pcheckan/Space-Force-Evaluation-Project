﻿namespace SpaceForceEvaluationAppLibrary.Models;

public class DailyQuestionsModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public int Id { get; set; }
    public string text { get; set; }
    public string category { get; set; }
    public float questionWeight { get; set; }
    public int questionPriority { get; set; }
}

