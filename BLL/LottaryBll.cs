using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ILottaryBll
    {
        Lottary GetLottaryPageModel();
    }
    public class LottaryBll : ILottaryBll
    {
       public Lottary GetLottaryPageModel()
        {
            int Min = 0;
            Random rnd = new Random();
           var kobiCardNumbers  = Enumerable.Range(1, 50).OrderBy(p => rnd.Next()).Take(24).Skip(0).ToArray();
            var aviCardNumbers = Enumerable.Range(1, 50).OrderBy(p => rnd.Next()).Take(24).Skip(0).ToArray();
            Lottary LottaryPageModel = new Lottary();
            LottaryPageModel.Boards = new List<Board>();
            //  LottaryPageModel.Boards.Add(new Board() { Numbers = new int[] { 33, 66, 2, 54, 1, 8, 55, 3, 11, 62, 75, 61, 15, 32, 4, 70, 59, 36, 20, 3, 52, 7, 17, 30 },PlayerName= "Kobi" });
            // LottaryPageModel.Boards.Add(new Board() { Numbers = new int[] { 33, 73, 2, 54, 1, 8, 55, 3, 23, 62, 75, 61, 15, 32, 4, 55, 59, 36, 20, 3, 52, 7, 17, 74 }, PlayerName = "Avi" });
            LottaryPageModel.Boards.Add(new Board() { Numbers = kobiCardNumbers, PlayerName = "Kobi" });
           // LottaryPageModel.Boards.Add(new Board() { Numbers = aviCardNumbers, PlayerName = "Avi" });
            LottaryPageModel.Balls = new List<Ball>() { new Ball { ID = 22 }, new Ball() { ID = 59 } };
            return LottaryPageModel;
        }
    }
}
