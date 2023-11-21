using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPatternBuilder.DBCon;

namespace WindowsFormsAppPatternBuilder.BuilderBurger
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddCheese();
        IBurgerBuilder AddBacon();
        IBurgerBuilder AddLettuce();
        IBurgerBuilder AddTomato();
        IBurgerBuilder AddPickles();
        Burgers GetBurgers();
    }
}
