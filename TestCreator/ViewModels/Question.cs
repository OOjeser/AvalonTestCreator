﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreator.ViewModels
{
    public class Question : ViewModelBase
    {
        public string QuestionText { get; set; }
        public string Answer
        {
            get;
            set;
        }
    }
}