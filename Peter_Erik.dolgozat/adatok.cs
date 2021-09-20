using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter_Erik.dolgozat
{
  class adatok
  {
    private string orszag;

    public string Orszag
    {
      get { return orszag; }
      set { orszag = value; }
    }

    

    private DateTime dateTime;

    public DateTime Ido
    {
      get { return dateTime; }
      set { dateTime = value; }
    }


    public adatok (string orszag,DateTime ido)
    {
      this.Orszag = orszag;
    
      this.Ido = dateTime;
    }

  }
}
