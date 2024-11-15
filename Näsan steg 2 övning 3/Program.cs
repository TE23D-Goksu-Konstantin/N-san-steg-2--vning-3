string[] namn = {"Jakob", "Ludvig", "Richard", "Vincent", "Simon"};

string[] träd = {"björkträd", "ekträd", "lönnträd", "tallträd", "barkträd"};

int[] t = {1,3,6,8,10};



for(int e = 0; e < 5; ++e){
    Console.WriteLine($"{namn[e]} hoppar från ett {träd[e]} och får betyget {t[e]} av domarna.");
}
Console.ReadLine();