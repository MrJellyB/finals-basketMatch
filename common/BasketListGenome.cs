using System;
using System.Collections.Generic;
using System.Text;

namespace common
{
    public class BasketListGenome : ListGenomes
    {
        #region Data Members

        private float[] m_weights;


        #endregion

        #region Properties

        public float[] Weights
        {
            get { return m_weights; }
            private set { m_weights = value; }
        }

        #endregion

        #region CTOR

        public BasketListGenome(long length) : base(length, 0, 100)
        {
            this.m_weights = new float[length];
            // TODO: insert here default weights list
        }

        #endregion

        #region Public Methods

        public void SetWeights(float[] weights)
        {
            this.m_weights = new float[weights.Length];

            for (int i = 0; i < weights.Length; i++)
            {
                SetWeight(weights[i], i);
            }
        }

        public void SetWeight(float weight, int valNum)
        {
            if (weight > 1 || weight < 0)
            {
                throw new Exception("the weight must be between 1 and 0");
            }

            this.m_weights[valNum] = weight; 
        }

        public override float FitnessFunction()
        {
            float productToReturn = 1f;

            for (int i = 0; i < this.Length; i++)
            {
                productToReturn *= (this.m_weights[i] * (float)this.m_list[i]);
            }

            return productToReturn;
        }

        #endregion
    }
}
