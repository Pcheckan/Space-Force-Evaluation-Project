﻿namespace SpaceForceEvaluationAppLibrary.DataAccess
{
    public interface ISurveyData
    {
        Task CreateSurvey(SurveyModel survey);
        Task<List<SurveyModel>> GetAllPastSurveys();
        Task<SurveyModel> GetSurvey(string id);
        Task<List<SurveyModel>> GetTodaysSurveys();
        Task UpdateSurvey(SurveyModel survey);
    }
}