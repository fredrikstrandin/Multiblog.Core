﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Miniblog.Core.Model.Setting
{
    public class MailSetting
    {
        public string InfoMailAdress { get; set; }
        public string InfoMailName { get; set; }
        public bool IsSandbox { get; set; }
    }
}
