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

        #region CTOR

        public BasketListGenome(long length) : base(length, 0, 100)
        {
            this.m_weights = new int[length];
            // TODO: insert here default weights list
        }

        #endregion

        #region Public Methods

        public void SetWeights(int[] weights)
        {
            
        }

        public void SetWeight(int weight, int valNum)
        {
            
        }

        #endregion
    }
}
