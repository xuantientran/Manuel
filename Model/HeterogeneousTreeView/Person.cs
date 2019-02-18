using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manuel
{

  public class Personne : SimpleObject
  {
    #region FirstName

    /// <summary>
    /// The farmer's first name.
    /// </summary>
    private string firstName = String.Empty;


    /// <summary>
    /// The farmer's first name.
    /// </summary>
    public string FirstName
    {
      get { return firstName; }
      set
      {
        //ignore if values are equal
        if (value == firstName) return;

        firstName = value;
				RaiseProperChanged("FirstName");
      }
    }

    #endregion

    #region LastName

    /// <summary>
    /// The person's last name.
    /// </summary>
    private string lastName = String.Empty;


    /// <summary>
    /// The person's last name.
    /// </summary>
    public string LastName
    {
      get { return lastName; }
      set
      {
        //ignore if values are equal
        if (value == lastName) return;

        lastName = value;
				RaiseProperChanged("LastName");
      }
    }

    #endregion

    /// <summary>
    /// This method is used by WPF to render the object if
    /// no data template is available.
    /// </summary>
    /// <returns>Just the first name.</returns>
    public override string ToString()
    {
      return FirstName;
    }
  }
}
