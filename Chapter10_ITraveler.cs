using System;

namespace Chapter10_ITraveler
{
    public interface ITravelerInterface
    {
        public string GetDestination();
        public string GetStartLocation();
        public double DetermineMiles();
    }
}
