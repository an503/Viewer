using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace shop
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
    public interface IObserver
    {
        void Update(Shop shop);
        void Update(ShopType currentShop);
    }
    public class Shop : ISubject
    {
        private List<IObserver> observers;
        private ShopType currentShop;

        public Shop()
        {
            observers = new List<IObserver>();
            currentShop = ShopType.Refrigerator;
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(currentShop);
            }
        }

        public void SetShop(ShopType shop)
        {
            currentShop = shop;
            NotifyObservers();
        }
    }

    public enum ShopType
    {
        Refrigerator, 
        Kettle,
        Micro, 
        Mixer 




    }
    public class ShopObserver : IObserver
    {
        private PictureBox pictureBox;

        public ShopObserver(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }
        public void Update(ShopType shop)
        {
            throw new NotImplementedException();
        }

        public class TreeObserver : IObserver
        {
            private PictureBox pictureBox;

            public TreeObserver(PictureBox pictureBox)
            {
                this.pictureBox = pictureBox;
            }

            public void Update(ShopType shop)
            {
                switch (shop)
                {
                    case ShopType.Refrigerator:
                        pictureBox.Image = viewer.Properties.Resources.Refrigerator;
                        break;
                    case ShopType.Kettle:
                        pictureBox.Image = viewer.Properties.Resources.Kettle;
                        break;
                    case ShopType.Micro:
                        pictureBox.Image = viewer.Properties.Resources.Micro;
                        break;
                    case ShopType.Mixer:
                        pictureBox.Image = viewer.Properties.Resources.Mixer;
                        break;
                }
            }

            public void Update(Shop shop)
            {
                throw new NotImplementedException();
            }
        }

        public void Update(Shop shop)
        {
            throw new NotImplementedException();
        }
    }


}
