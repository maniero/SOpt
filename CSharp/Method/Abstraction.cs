public static StudyLogRepository BuildStudyLog() => new StudyLogRepository().Create(new StudyLog() {
    StudyId = Study.Id,
    CycleId = null,
    DateOccurrence = DateTime.Now,
    CycleActionName = "Nova estudo gerado",
    UserId = int.Parse(System.Web.HttpContext.Current.Session[SessionKeys.USER_ID].ToString())
});

//https://pt.stackoverflow.com/q/203139/101
