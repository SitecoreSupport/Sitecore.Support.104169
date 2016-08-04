﻿using System.ComponentModel;
using Sitecore.Forms.Mvc.Attributes;

namespace Sitecore.Support.Forms.Mvc.ViewModels.Fields
{
  public class CheckboxListField : Sitecore.Forms.Mvc.ViewModels.Fields.CheckboxListField
  {
    [ParameterName("Direction"), TypeConverter(typeof(StringConverter))]
    public string Direction
    {
      get;
      set;
    }

    [ParameterName("Columns"), TypeConverter(typeof(Int32Converter))]
    public int Columns
    {
      get;
      set;
    }
  }
}