using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Bwell_v1
{
    class Substance
    {
        string subName;
        List<Substance> volatiles;


        Substance(string name, List<Substance> volatiles)
        {
            this.subName = name;
            this.volatiles = volatiles;
        }

        protected void addToVolatiles(Substance substance)
        {
            volatiles.Add(substance);
        }
    }
}