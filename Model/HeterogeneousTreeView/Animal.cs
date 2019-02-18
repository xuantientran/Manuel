using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manuel
{
  public class Animal : SimpleObject
  {
    #region AnimalName

    /// <summary>
    /// The animal animalName.
    /// </summary>
    private string animalName = String.Empty;


    /// <summary>
    /// The animal animalName.
    /// </summary>
    public string AnimalName
    {
      get { return animalName; }
      set
      {
        //ignore if values are equal
        if (value == animalName) return;

        animalName = value;
				RaiseProperChanged("AnimalName");
      }
    }

    #endregion

    public Animal(string animalName)
    {
      this.animalName = animalName;
    }


    /// <summary>
    /// This method is used by WPF to render the object if
    /// no data template is available.
    /// </summary>
    /// <returns>Just the animal name.</returns>
    public override string ToString()
    {
      return AnimalName;
    }
  }
}
