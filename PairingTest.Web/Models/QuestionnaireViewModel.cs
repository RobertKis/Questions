﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PairingTest.Web.Models
{
    public class QuestionnaireViewModel
    {
        public string QuestionnaireTitle { get; set; }
        public IList<string> QuestionsText { get; set; }
    }

    public class QuestionnaireList
    {
        public QuestionnaireViewModel qaItem { get; set; }
    }
}