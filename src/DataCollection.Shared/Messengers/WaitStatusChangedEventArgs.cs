﻿/*******************************************************************************
  * Copyright 2019 Esri
  *
  *  Licensed under the Apache License, Version 2.0 (the "License");
  *  you may not use this file except in compliance with the License.
  *  You may obtain a copy of the License at
  *
  *  https://www.apache.org/licenses/LICENSE-2.0
  *
  *   Unless required by applicable law or agreed to in writing, software
  *   distributed under the License is distributed on an "AS IS" BASIS,
  *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  *   See the License for the specific language governing permissions and
  *   limitations under the License.
******************************************************************************/

using System;

namespace Esri.ArcGISRuntime.OpenSourceApps.DataCollection.Shared.Messengers
{
    /// <summary>
    /// EventArgs class for the UserPromptMessenger
    /// </summary>
    public class WaitStatusChangedEventArgs : EventArgs
    {

        /// <summary>
        /// Whether a modal overlay should prevent user interaction with the app
        /// </summary>
        public bool IsBusy { get; set; }

        /// <summary>
        /// Gets or sets the message to be shown to the user
        /// </summary>
        public string Message { get; set; }
    }
}
