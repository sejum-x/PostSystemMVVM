using System.Collections.ObjectModel;
using PostSystemMVVM.Command;
using PostSystemMVVM.Model;
using System;

namespace PostSystemMVVM.ViewModel
{
    class OrderViewModel : BaseViewModel
    {
        public ObservableCollection<Order> Orders { get; set; }
        private Order selectedOrder;
        private Order editingOrder;

        private CustomCommand addOrderCmd;
        private CustomCommand removeOrderCmd;
        private CustomCommand editOrderCmd;

        public CustomCommand AddOrderCmd
        {
            get
            {
                return addOrderCmd ?? (addOrderCmd = new CustomCommand(
                    obj =>
                    {
                        if (EditingOrder != null) // Якщо редагуємо існуюче замовлення
                        {
                            // Оновлюємо дані існуючого замовлення
                            var index = Orders.IndexOf(SelectedOrder);
                            Orders[index] = EditingOrder;
                            EditingOrder = null; // Очищуємо редагування
                        }
                        else // Додаємо нове замовлення
                        {
                            // Перевіряємо наявність необхідних даних
                            if (string.IsNullOrWhiteSpace(EditingOrder.Sender) || string.IsNullOrWhiteSpace(EditingOrder.Receiver))
                            {
                                // Можна додати обробку помилки, якщо дані не валідні
                                return;
                            }

                            var newOrder = new Order
                            {
                                Id = Orders.Count + 1, // Автоматичне призначення ID
                                Sender = EditingOrder.Sender,
                                Receiver = EditingOrder.Receiver,
                                PackageWeight = EditingOrder.PackageWeight,
                                SenderBranch = EditingOrder.SenderBranch,
                                ReceiverBranch = EditingOrder.ReceiverBranch,
                                Price = EditingOrder.Price,
                                OrderDate = DateTime.Now,
                                PaymentType = EditingOrder.PaymentType,
                                PaymentStatus = PaymentStatus.Pending,
                                OrderStatus = OrderStatus.Pending
                            };

                            Orders.Add(newOrder);
                            SelectedOrder = newOrder; // Встановлюємо вибране нове замовлення
                            EditingOrder = null; // Очищуємо форму після додавання
                        }
                    },
                    (obj) => true
                ));
            }
        }



        public CustomCommand RemoveOrderCmd
        {
            get
            {
                return removeOrderCmd ?? (removeOrderCmd = new CustomCommand(
                    obj =>
                    {
                        if (SelectedOrder != null)
                        {
                            Orders.Remove(SelectedOrder);
                            SelectedOrder = null; // Очищуємо вибране
                        }
                    },
                    (obj) => SelectedOrder != null
                ));
            }
        }


        public CustomCommand EditOrderCmd
        {
            get
            {
                return editOrderCmd ?? (editOrderCmd = new CustomCommand(
                    obj =>
                    {
                        if (SelectedOrder != null)
                        {
                            // Копіюємо дані вибраного замовлення в редаговане
                            EditingOrder = new Order
                            {
                                Id = SelectedOrder.Id,
                                Sender = SelectedOrder.Sender,
                                Receiver = SelectedOrder.Receiver,
                                PackageWeight = SelectedOrder.PackageWeight,
                                SenderBranch = SelectedOrder.SenderBranch,
                                ReceiverBranch = SelectedOrder.ReceiverBranch,
                                Price = SelectedOrder.Price,
                                OrderDate = SelectedOrder.OrderDate,
                                PaymentType = SelectedOrder.PaymentType,
                                PaymentStatus = SelectedOrder.PaymentStatus,
                                OrderStatus = SelectedOrder.OrderStatus
                            };
                        }
                    },
                    (obj) => SelectedOrder != null
                ));
            }
        }



        public Order EditingOrder
        {
            get { return editingOrder; }
            set
            {
                editingOrder = value;
                OnPropertyChanged(nameof(EditingOrder));
            }
        }

        public Order SelectedOrder
        {
            get { return selectedOrder; }
            set
            {
                selectedOrder = value;
                OnPropertyChanged(nameof(SelectedOrder));
            }
        }

        public OrderViewModel()
        {
            Orders = new ObservableCollection<Order>
            {
                new Order(1, "0966253699", "0966253699", 10, "Lviv", "Izyaslav", "08781238", 100, DateTime.Now, PaymentType.Card, PaymentStatus.Pending, OrderStatus.Pending),
                new Order(2, "3562837627", "9872131023", 10, "Odesa", "Izyaslav", "08123138", 120, DateTime.Now, PaymentType.Cash, PaymentStatus.Paid, OrderStatus.InProgress),
                new Order(3, "0966253699", "0966253699", 10, "Izyaslav", "Turka", "098237323", 80, DateTime.Now, PaymentType.Transfer, PaymentStatus.Canceled, OrderStatus.Canceled),
            };
        }
    }
}
