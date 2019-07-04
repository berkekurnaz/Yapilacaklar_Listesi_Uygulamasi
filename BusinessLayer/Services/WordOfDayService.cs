using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.BusinessLayer.Services
{
    public class WordOfDayService
    {

        static List<string> words = new List<string>()
        {
            "Sıkı çalışmanın yerini hiçbir şey alamaz. Dehanın %1’i ilham, %99’ u alın teridir. Thomas Edison",
            "Düşünmeden konuşmanın cezası sonradan düşünmeye mahkûm olmaktır. Thomas Edison",
            "Hiç yanılmadım, 10.000 tane işe yaramayan yol buldum. Thomas Edison",
            "Her şey için zaman vardır. Thomas Edison",
            "Biz hiçbir şeyin milyonda birini bile bilmiyoruz. Thomas Edison",
            "Savaş kazanıldı, barış değil.",
            "İnsanlardaki önyargıyı parçalamak atomu parçalamaktan daha zordur. Albert Einstein",
            "Mutlu hayat yaşamak istiyorsanız hayatınızı bir amaca bağlayın, kişilere veya eşyalara değil. Albert Einstein",
            "İlk önce oyunun kurallarını öğrenmelisiniz, sonra da herkesten iyi oynamayı. Albert Einstein",
            "Aptallık ve dâhilik arasındaki fark; dâhiliğin sınırları olmasıdır. Albert Einstein",
            "Hiç kuşkum yok ki bilim ve barış cehalet ve savaşı yok edecektir. Pasteur ",
            "Talih hazır olan kafalara yardım eder. Pasteur ",
            "Yükselmek hayatın sırrını öğrenmekle olur. Pasteur ",
            "Şans, her zaman akıllıları tercih eder. Pasteur ",
            "Beni amacıma ulaştıran sırrı söyleyeyim size. Gücümün tek kaynağı olan azmim. Pasteur ",
            "İnsanın felaketi, sessizce odasında, ait olduğu yer olan odasında oturmak istememesinden gelir. Pascal",
            "Çok büyük bir ihtimalle, bir gemiye kaptan olarak, o gemide doğmuş birini seçmeyiz. Pascal",
            "Kuvvete dayanmayan adalet aciz, adalete dayanmayan kuvvet zalimdir. Pascal",
            "Kalbin kendine has nedenleri vardır ki, akıl hiç bir zaman anlayamaz. Pascal",
            "Bir yapıt oluştururken en son bulduğumuz şey, en başa neyin konulması gerektiğidir. Pascal",
            "Yıldızların hareketlerini hesaplayabilirim ancak insanların deliliklerini değil. Newton",
            "Eğer daha ileriyi gördüysem, devlerin omuzlarında durduğum için olmuştur. Newton",
            "Biz düşüncelerimiz değiliz, biz düşüncelerimizin düşüncesiyiz. Newton",
            "Diğer tüm kanıtları bir yana bırakırsak başparmak bile benim Tanrı’nın varlığına inanmam için yeterlidir. Newton",
        };
        
        public static string GetWord()
        {
            Random random = new Random();
            int number = random.Next(0, words.Count);
            return words[number];
        }

    }
}
