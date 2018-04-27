using System;
using System.Collections.Generic;
using System.Text;

namespace common
{
    public class BasketListGenome : ListGenomes
    {
        #region Data Members

        private int[] m_weights;


        #endregion

        #region Properties

        public int[] Weights
        {
            get { return m_weights; }
            private set { m_weights = value; }
        }

        #endregion
    }
}
