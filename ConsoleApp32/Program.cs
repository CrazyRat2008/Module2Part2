using Autofac;
using ConsoleApp32;
using static ConsoleApp32.Appliance;
using static ConsoleApp32.Geometry;
//coctail
ContainerBuilder builder = new ContainerBuilder();
builder.RegisterType<MockCocktailRepository>().As<ICocktailRepository>();
builder.RegisterType<CocktailService>();
var container = builder.Build();

var cocktailService = container.Resolve<CocktailService>();
var cocktails = cocktailService.GetAllCocktails();
//heros
builder = new ContainerBuilder();
builder.RegisterType<Infantryman>().As<GameCharacter>();
builder.RegisterType<Spearman>().As<GameCharacter>();
builder.RegisterType<Archer>().As<GameCharacter>();
container = builder.Build();
var infantryman = container.Resolve<Infantryman>();
var spearman = container.Resolve<Spearman>();
var archer = container.Resolve<Archer>();
infantryman.Attack(spearman);
Console.WriteLine(infantryman.GetInfo());
//figures
builder = new ContainerBuilder();
builder.RegisterType<Circle>().As<IGeometricFigure>();
builder.RegisterType<Square>().As<IGeometricFigure>();
container = builder.Build();

var circle = container.Resolve<Circle>();
var square = container.Resolve<Square>();

Console.WriteLine(circle.GetInfo());
Console.WriteLine(square.GetInfo());

using (StreamWriter writer = new StreamWriter("figures.txt"))
{
    writer.WriteLine(circle.GetInfo());
    writer.WriteLine(square.GetInfo());
}

//appliance
builder = new ContainerBuilder();
builder.RegisterType<CoffeeGrinder>().As<IAppliance>();
builder.RegisterType<Mixer>().As<IAppliance>();
builder.RegisterType<Blender>().As<IAppliance>();
  container = builder.Build();

var coffeeGrinder = container.Resolve<IAppliance>(new TypedParameter(typeof(string), "KitchenAid"), new TypedParameter(typeof(string), "KCG0702ER"));
var mixer = container.Resolve<IAppliance>(new TypedParameter(typeof(string), "Cuisinart"), new TypedParameter(typeof(string), "HM-90BCS"));
var blender = container.Resolve<IAppliance>(new TypedParameter(typeof(string), "Ninja"), new TypedParameter(typeof(string), "BL770"));

Console.WriteLine(coffeeGrinder.GetInfo());
Console.WriteLine(mixer.GetInfo());
Console.WriteLine(blender.GetInfo());

using (StreamWriter writer = new StreamWriter("appliances.txt"))
{
    writer.WriteLine(coffeeGrinder.GetInfo());
    writer.WriteLine(mixer.GetInfo());
    writer.WriteLine(blender.GetInfo());
}