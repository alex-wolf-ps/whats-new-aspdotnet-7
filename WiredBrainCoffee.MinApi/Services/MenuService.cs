using WiredBrainCoffee.MinApi.Services.Interfaces;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.MinApi.Services
{
    public class MenuService : IMenuService
    {
        public List<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>() {
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
                },
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
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Charcuterie",
                    ShortDescription = "Food for friends.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/charcuterie.jpg",
                    Price = 8,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Apple Turnover",
                    ShortDescription = "Lighter on calories and texture, heavy on flavor.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/applefritter.jpg",
                    Price = 6,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Cupcake",
                    ShortDescription = "Vanilla cupcakes with the perfect level of sweetness.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/cupcake.jpg",
                    Price = 4,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Marshmallow Berry Drizzle",
                    ShortDescription = "Simplicity is the ultimate sophistication.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/berry-drizzle.jpg",
                    Price = 4,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Muffin",
                    ShortDescription = "A freshly baked chocolate chip muffin - the perfect way to start a Monday morning.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/muffin.jpg",
                    Price = 3,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Chocolate Bites",
                    ShortDescription = "Rich and sweet chocolate bites for those in need of a special treat.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/chocolate.jpg",
                    Price = 5,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 1,
                    Name = "Frosted Pumpkin Bread",
                    Slug = "pumpkin-bread",
                    ShortDescription = "A seasonal delight we offer every autumn.  Pumpking bread with just a bit of spice, cream cheese frosting with just a hint of home.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/pumpkinbread.jpg",
                    Price = 4,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Granola with Nuts",
                    ShortDescription = "It's not flashy, but it sure is healthy.  Perfect for when you need the calories, but not the guilt.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/granola.jpg",
                    Price = 3,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 4,
                    Name = "Chocolate Chip Cookies",
                    ShortDescription = "They're made fresh every day, and they taste like it..",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/cookies.jpg",
                    Price = 2,
                    Category = "Food"
                },
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
                },
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
                },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Raspberry Iced Tea",
                    ShortDescription = "A perfect blend of flavor and caffeine.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/raspberry-tea.jpg",
                    Price = 3.5M,
                    Category = "Coffee"
                },
                new MenuItem()
                {
                    Id = 1,
                    Name = "Dark Brewed Coffee",
                    Slug = "dark-brew",
                    ShortDescription = "A classic, refreshing original.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/ground.jpg",
                    Price = 2,
                    Category = "Coffee"
                },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Latte",
                    ShortDescription = "More than just coffee, but still just coffee.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/cappucino.jpg",
                    Price = 3,
                    Category = "Coffee"
                },
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
            };
        }
    }
}
