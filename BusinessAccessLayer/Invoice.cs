using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class Invoice : IPayable
    {
        public string PartNumber { get; }
        public string PartDescription { get; }
        private int _quanitity;
        private decimal _pricePerItem;

        public Invoice() { }

        public Invoice(string partnumber, string partDescription, int quantity, decimal pricePerItem)
        {
            PartNumber = partnumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public int Quantity {
            get { return _quanitity; }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Quantity should be positive or zero");
                }
                _quanitity = value;
            }
        }

        public decimal PricePerItem {
            get { return _pricePerItem; }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Price per item should be positive or zero");
                }
                _pricePerItem = value;
            }
        }

        public override string ToString()
        {
            return "Part Number: " + PartNumber + " Part Description: " + PartDescription + "\n" +
                "Quantity: " + Quantity + " Price Per Item: " + PricePerItem + "\n";
        }

        public decimal GetPaymentAmount() {
            return PricePerItem * Quantity;
        }
    }
}
