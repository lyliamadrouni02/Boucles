namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : faire un compteur qui va de 1 à 10
        int fin = 11
        for (int compteur = 0; compteur < fin; compteur++)
        {
            Console.WriteLine(compteur);
        }
        Console.WriteLine("Instruction 2");
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        int fin = 0
        for (int compteur = 5; compteur > fin; compteur--)
        {
            Console.WriteLine(compteur);
        }
        Console.WriteLine("Bonne année !");
        // Etape 3 : faire un compteur qui va de -4 à 2
        int fin = 3
        for (int compteur = -4, compteur < fin; compteur++)
        {
            Console.WriteLine(compteur);
        }
        Console.WriteLine("Insturction 2");
        
        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        int fin = 16
        for (int compteur = 0; compteur < fin; compteur++2)
        {
            Console.WriteLine(compteur);
        }
        Console.WriteLine("Instruction 2");

        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        console.ReadLine();
        string answer = true
        do 
        {
            Console.ReadLine();
        } while (answer /= true)

        
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}