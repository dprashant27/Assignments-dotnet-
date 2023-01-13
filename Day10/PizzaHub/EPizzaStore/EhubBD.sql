show databases;
use dotnet;

create table Pizza(
            Img varchar(25) not null,
            PizzaId int primary key auto_increment,
            PizzaName varchar(25),
            Descp varchar (30) ,
            Quantity int not null,
            Price decimal(9,2)
);

insert into Pizza values ("/images/CheesePizza.jpg", 1, "Cheese Pizza", "It should be no shocker that a classic is the statistical favorite. Cheese pizza is one of the most popular choices. It will always be a simple, unadorned masterpiece on its own.", 50, 299),
                        ("/images/VeggiePizza.jpg", 2, "Veggie Pizza", "When you want to jazz up your cheese pizza with color and texture, veggies are the perfect topping. And you're only limited by your imagination. Everything from peppers and mushrooms, to eggplant and onions make for an exciting and tasty veggie pizza.", 60, 399),
                        ("/images/PepperoniPizza.jpg", 3, "Pepperoni Pizza", "There's a reason this is one of the most popular types of pizza. Who doesn't love biting into a crispy, salty round of pepperoni?", 40, 245),
                        ("/images/MeatPizza.jpg", 4, "Meat Pizza", "If pepperoni just isn't enough, and you're looking for a pie with a bit more heft, a meat pizza is a perfect and popular choice. Pile on ground beef and sausage for a hearty meal.", 35, 450),
                        ("/images/MargheritaPizza.jpg", 5, "Margherita Pizza", "Deceptively simple, the Margherita pizza is made with basil, fresh mozzarella, and tomatoes. There's a reason it's an Italian staple and one of the most popular types of pizza in the country.", 50, 385),
                        ("/images/BBQ_ChickenPizza.jpg", 6, "BBQ Chicken Pizza", "If you love BBQ chicken and you love pizza, why not put them together? This has long been a cult favorite of sports fans and college kids. The chicken slathered over the top of a pie gives it a tangy, sweet flavor that can't be beaten", 40, 500),
                        ("/images/hawaiian-pizza.jpg", 7, "Hawaiian Pizza", "Pineapple might not be the first thing that comes to mind when you think pizza. But add in some ham and it creates an unexpectedly solid sweet and salty combination for this type of pizza", 50, 455),
                        ("/images/SupremePizza.jpg", 8, "Supreme Pizza", "When you can't decide which toppings to get, it's time for the supreme pizza. The “supreme” refers to the litany of toppings that come scattered on these pies, from sausage to vegetables to pepperoni. And it's the combination of the flavors that really makes it sing.", 35, 325);

select * from Pizza;  
  