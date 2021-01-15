using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador_RGB.Internals.Effects
{
    public interface iEffects
    {
        string Name { get; }

        /// <summary>
        /// method while the effect is on
        /// </summary>
        void Play();

        /// <summary>
        /// Method to stop effect.
        /// </summary>
        void Stop();
    }
}
