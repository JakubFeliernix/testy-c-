//1________________________________________________________________
//główny program
namespace sumy
{
    public class Suma
    {
        public float Decyzja(float[] tablica)
            {
            float sum = Sumy(tablica);
                if(sum > 20)
                {
                    
                    List<float>parzyste = new List<float>();
                    foreach (var i in tablica) if(i%2==0) parzyste.Add(i);
                    return Sumy(parzyste.ToArray());
                }
                else if(sum <= 10)
                {
                    return sum/tablica.Length;
                }
                else
                {
                
                    List<float>nieparzyste = new List<float>();
                    foreach (var i in tablica) if(i%2==1) nieparzyste.Add(i);
                    return Sumy(nieparzyste.ToArray());
                }
            }
        private float Sumy(float[] tablica)
            {
                float suma = 0;
                foreach (var i in tablica) suma+=i;
                return suma;
                
            }
    }
}

