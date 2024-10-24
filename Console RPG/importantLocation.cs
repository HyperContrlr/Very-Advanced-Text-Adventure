using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class ImportantLocation : LocationEvent
    {
        public ImportantLocation(bool isResolved) : base(isResolved)
        {
        }

        public override void Resolve(List<Player> player, List<Ally> allies)
        {
            if (this.isResolved)
            {
                return;
            }
            throw new NotImplementedException();
        }
    }
}
