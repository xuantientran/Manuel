using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manuel
{
  public class Plant : SimpleObject
  {
    #region PlantName

    /// <summary>
    /// The plant's name.
    /// </summary>
    private string plantName = String.Empty;


    /// <summary>
    /// The plant's name.
    /// </summary>
    public string PlantName
    {
      get { return plantName; }
      set
      {
        //ignore if values are equal
        if (value == plantName) return;

        plantName = value;
				RaiseProperChanged("PlantName");
      }
    }

    #endregion

    public Plant(string plantName)
    {
      this.plantName = plantName;
    }

    /// <summary>
    /// This method is used by WPF to render the object if
    /// no data template is available.
    /// </summary>
    /// <returns>Just the plant name.</returns>
    public override string ToString()
    {
      return PlantName;
    }
  }
}
