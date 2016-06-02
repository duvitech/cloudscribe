﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2015-09-13
// Last Modified:			2016-05-11
//

using System;

namespace cloudscribe.Core.Web.ViewModels.SiteSettings
{
    public class RegisterInfoViewModel
    {
        public Guid SiteId { get; set; } = Guid.Empty;
        public string RegistrationPreamble { get; set; } = string.Empty;
        public string RegistrationAgreement { get; set; } = string.Empty;  
    }
}
