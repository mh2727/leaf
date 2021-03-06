﻿// Copyright (c) 2019, UW Medicine Research IT, University of Washington
// Developed by Nic Dobbins and Cliff Spital, CRIO Sean Mooney
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
using System;
using Model.Cohort;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class PatientCohortTests
    {
        [Fact]
        public void SeasonedPatients_Should_Only_Export_Up_To_MaxSize()
        {
            var cohort = new PatientCohort
            {
                PatientIds = new HashSet<string>(new string[]
                {
                    "a","b","c","d","e","f","g"
                })
            };
        }
    }
}
