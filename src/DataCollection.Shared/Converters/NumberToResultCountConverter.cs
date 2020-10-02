﻿/*******************************************************************************
  * Copyright 2020 Esri
  *
  *  Licensed under the Apache License, Version 2.0 (the "License");
  *  you may not use this file except in compliance with the License.
  *  You may obtain a copy of the License at
  *
  *  http://www.apache.org/licenses/LICENSE-2.0
  *
  *   Unless required by applicable law or agreed to in writing, software
  *   distributed under the License is distributed on an "AS IS" BASIS,
  *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  *   See the License for the specific language governing permissions and
  *   limitations under the License.
******************************************************************************/

using System;
using Esri.ArcGISRuntime.OpenSourceApps.DataCollection.Shared.Properties;
#if NETFX_CORE
using Windows.UI.Xaml.Data;
using CustomCultureInfo = System.String;
#else
using System.Windows.Data;
using CustomCultureInfo = System.Globalization.CultureInfo;
#endif

namespace Esri.ArcGISRuntime.OpenSourceApps.DataCollection.Shared.Converters
{
    /// <summary>
    /// Converter returns the input value with a suffix defined by the parameter's localization resource key.
    /// </summary>
    public class NumberToResultCountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CustomCultureInfo culture)
        {

            return $"{value} {Resources.GetString(parameter.ToString())}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CustomCultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
