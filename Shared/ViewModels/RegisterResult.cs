﻿using System.Collections.Generic;

namespace Artha.Shared.ViewModels
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
