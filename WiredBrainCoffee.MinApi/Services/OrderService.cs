using WiredBrainCoffee.MinApi.Services.Interfaces;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.MinApi.Services
{
    public class OrderService : IOrderService
    {
        public List<Order> Orders { get; set; } = new List<Order>();

        public OrderService()
        {
            Orders = new List<Order>(){
                new Order
                {
                    Id = 1,
                    Notes = "A coffee order",
                    LastName = "Smith",
                    FirstName = "Joe",
                    PromoCode = "WiredFall",
                    Created = DateTime.Now.AddDays(-2),
                    OrderNumber = 100,
                    Items = new List<MenuItem>()
                    {
                        new MenuItem()
                        {
                            Id = 6,
                            Name = "Red Velvet",
                            ShortDescription = "Red Velvet is finally here.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/cake.jpg",
                            Price = 6,
                            Category = "Food"
                        },
                        new MenuItem()
                        {
                            Id = 6,
                            Name = "Salted Caramel Chocolate Cake",
                            ShortDescription = "Super sweet, slightly salty.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/cake-brown.jpg",
                            Price = 7,
                            Category = "Food"
                        }
                    }
                },
                new Order
                {
                    Id = 2,
                    Notes = "A food order",
                    Created = DateTime.Now,
                    OrderNumber = 125,
                    LastName = "Doe",
                    FirstName = "John",
                    Items = new List<MenuItem>()
                    {
                        new MenuItem()
                        {
                            Id = 6,
                            Name = "Gourmet Cupcakes",
                            ShortDescription = "The flavor of a full size cake.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/cupcakes.jpg",
                            Price = 6,
                            Category = "Food"
                        },
                        new MenuItem()
                        {
                            Id = 6,
                            Name = "Caeser salad",
                            ShortDescription = "The perfect light lunch.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/salad-house.jpg",
                            Price = 8,
                            Category = "Food"
                        },
                        new MenuItem()
                        {
                            Id = 6,
                            Name = "Wired Salad",
                            ShortDescription = "Unique ingredients, wired flavor.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/salad-special.jpg",
                            Price = 8,
                            Category = "Food"
                        }
                    }
                },
                new Order
                {
                    Id = 3,
                    Notes = "A small order",
                    PromoCode = "Wired123",
                    LastName = "Testing",
                    FirstName = "Frank",
                    Created = DateTime.Now.AddDays(-4).AddHours(10),
                    OrderNumber = 133,
                    Items= new List<MenuItem>() {
                        new MenuItem()
                        {
                            Id = 6,
                            Name = "Charcuterie",
                            ShortDescription = "Food for friends.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/charcuterie.jpg",
                            Price = 8,
                            Category = "Food"
                        }
                    }
                },
                new Order
                {
                    Id = 4,
                    Notes = "An order for Americano",
                    Created = DateTime.Now,
                    OrderNumber = 155,
                    LastName = "Smith",
                    FirstName = "Joe",
                    Items = new List<MenuItem>() {
                        new MenuItem()
                        {
                            Id = 2,
                            Name = "Americano",
                            Slug = "ground-coffee",
                            ShortDescription = "Still classic, but a little more sophisticated.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/beans.jpg",
                            Price = 3.5M,
                            Category = "Coffee"
                        },
                        new MenuItem()
                        {
                            Id = 3,
                            Name = "Cappuccino",
                            ShortDescription = "Rich and foamy, its the perfect comfort-coffee.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/cup.jpg",
                            Price = 4.5M,
                            Category = "Coffee"
                        }
                    }
                },
                new Order
                {
                    Id = 4,
                    Notes = "Employee order",
                    Created = DateTime.Now,
                    OrderNumber = 180,
                    LastName = "Americano",
                    FirstName = "Jeff",
                    Items = new List<MenuItem>() {
                        new MenuItem()
                        {
                            Id = 3,
                            Name = "Matcha Green Tea",
                            ShortDescription = "A gentler introduction to caffeine.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/matcha.jpg",
                            Price = 3.5M,
                            Category = "Coffee"
                        },
                        new MenuItem()
                        {
                            Id = 3,
                            Name = "Mocha Latte",
                            ShortDescription = "Dark chocolate flavor in dark brew coffee.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/iced-mocha.jpg",
                            Price = 3.5M,
                            Category = "Coffee"
                        },
                        new MenuItem()
                        {
                            Id = 3,
                            Name = "Secret Brew",
                            ShortDescription = "What is it? You'll have to try it to find out.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/latte.jpg",
                            Price = 3.5M,
                            Category = "Coffee"
                        }
                    }
                },
                new Order
                {
                    Id = 6,
                    Notes = "A company order",
                    Created = DateTime.Now.AddDays(-10).AddHours(5),
                    OrderNumber = 190,
                    LastName = "Test",
                    FirstName = "Jane",
                    Items = new List<MenuItem>() {
                        new MenuItem()
                        {
                            Id = 5,
                            Name = "Fresh Bagels",
                            ShortDescription = "They're just as round as donuts, but far more healthy! Freshly made every morning before sunrise.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/bagel.jpg",
                            Price = 5,
                            Category = "Food"
                        },
                        new MenuItem()
                        {
                            Id = 3,
                            Name = "Designer Espresso",
                            ShortDescription = "Caffine has never looked so stunning.",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                            ImageFile = "images/menu/design.jpg",
                            Price = 6.5M,
                            Category = "Coffee"
                        }
                    }
                }
            };
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        public Order GetOrderById(int id)
        {
            return Orders.FirstOrDefault(x => x.Id == id);
        }

        public Order AddOrder(Order order)
        {
            Orders.Add(order);

            return order;
        }

        public void UpdateOrder(int id, Order newOrder)
        {
            var order = Orders.FirstOrDefault(x => x.Id == id);

            order.Notes = newOrder.Notes;
            order.PromoCode = newOrder.PromoCode;
            order.OrderNumber = newOrder.OrderNumber;
        }

        public void DeleteOrder(int id)
        {
            var order = Orders.FirstOrDefault(x => x.Id == id);
            Orders.Remove(order);
        }
    }
}
