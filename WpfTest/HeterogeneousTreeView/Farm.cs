using Manuel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfTest
{
  public class Farm : SimpleObject
  {
    #region FarmName

    /// <summary>
    /// The farm's name.
    /// </summary>
    private string farmName = String.Empty;


    /// <summary>
    /// The farm's name.
    /// </summary>
    public string FarmName
    {
      get { return farmName; }
      set
      {
        //ignore if values are equal
        if (value == farmName) return;

        farmName = value;
				RaiseProperChanged("FarmName");
      }
    }

    #endregion

    #region Farmer

    /// <summary>
    /// The person that owns the farm.
    /// </summary>
    private Person farmer;


    /// <summary>
    /// The person that owns the farm.
    /// </summary>
    public Person Farmer
    {
      get { return farmer; }
      set
      {
        //ignore if values are equal
        if (value == farmer) return;

        farmer = value;
				RaiseProperChanged("Farmer");
      }
    }

    #endregion

    #region Animals

    /// <summary>
    /// The animals you find on the farm.
    /// </summary>
    private ObservableCollection<Animal> animals = new ObservableCollection<Animal>();


    /// <summary>
    /// The animals you find on the farm.
    /// </summary>
    public ObservableCollection<Animal> Animals
    {
      get { return animals; }
      set
      {
        //ignore if values are equal
        if (value == animals) return;

        animals = value;
				RaiseProperChanged("Animals");
      }
    }

    #endregion

    #region Crops

    /// <summary>
    /// The cultivated plants.
    /// </summary>
    private ObservableCollection<Plant> crops = new ObservableCollection<Plant>();


    /// <summary>
    /// The cultivated plants.
    /// </summary>
    public ObservableCollection<Plant> Crops
    {
      get { return crops; }
      set
      {
        //ignore if values are equal
        if (value == crops) return;

        crops = value;
				RaiseProperChanged("Crops");
      }
    }

    #endregion

    /// <summary>
    /// This method is used by WPF to render the object if
    /// no data template is available.
    /// </summary>
    /// <returns>Return the farmer name.</returns>
    public override string ToString()
    {
      return String.Format("{0}'s Farm", farmer.FirstName);
    }
  }
}
