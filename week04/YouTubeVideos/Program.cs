using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("YouTubeVideos Project");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine(" ");

        List<Video> myVideo = new();
        myVideo.Add(new Video("Informe Mundial de octubre de 2026", "@IglesiadeJesucristoESP", 2675));
        myVideo[0].AddComment("@MariaLeon-v3z", "Ojala algun dia estemos unidos todos los Cristianos, còmo lo pidio Cristo que todos seamos uno en èl, me gusto mucho el templo con la escultura de nuestro Señor Jesùs bendiciones de una catolica Ecuatoriana. ❤❤❤");
        myVideo[0].AddComment("@esperanzamartinez6710", "Cada día me siento muy contenta  de pertenecer a la Iglesia  de Jesucristo  de los santos de los últimos días");
        myVideo[0].AddComment("@MiriamReiser-o9p", "Siempre el señor nos cuida y nos bendice y ama a todos❤");
        myVideo[0].AddComment("@kattypinorodriguez5696", "Amo la obra del señor ❤❤❤❤ gracias");

        myVideo.Add(new Video("Mayor amor: Un mensaje de esperanza de la Primera Presidencia", "@IglesiadeJesucristoESP", 148));
        myVideo[1].AddComment("@gabrielavaldes3690", "Que el sacrificio expiatorio del Salvador no sea en vano en nuestras vidas, y podamos con amor, fe y esperanza seguir Sus pasos y confiar en Él. Gracias por tener un Profeta y Apóstoles que reciben revelación y nos brindan un hermoso mensaje de Pascua!! ❤🙏");
        myVideo[1].AddComment("@mariainesmenesesrodriguez6871", "Gracias mis amados amigos y profetas de Dios por guiarnos en estos caminos escabrosos ❤");
        myVideo[1].AddComment("@uldagacitua6597", "Gracias por tenerlos  y sus mensajes de esperanzas llenan mi ❤");

        myVideo.Add(new Video("Welcome to Brigham Young University", "Brigham Young University", 186));
        myVideo[2].AddComment("@protochris", "I hope to visit there soon for my undergrad. Seems like my kind of school.");
        myVideo[2].AddComment("@aidamelly4241", "I will join in according to Gods will i believe in no coincedences God orchastrates things to align to His purpose");
        myVideo[2].AddComment("@林恩右-r3q", "Wish I can go to BYU in the future");
        foreach (Video video in myVideo)
        {
            Console.WriteLine($"{video.GetVideo()}");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"Comments ({video.GetNumberOfComments()}): ");
            foreach (Comment comment in video.GetComment())
            {
                Console.WriteLine($"{comment.DisplayComment()}");

            }
            Console.WriteLine(" ");
        }

    }
}