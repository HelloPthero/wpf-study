using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTestProject.Model;

namespace WPFTestProject.ViewModel
{
    public class MusicViewModel
    {
        public List<string> MenuList { get; set; }
        public List<MenuModel> MenuList2 { get; set; }

        public List<string> MenuList3 { get; set; }

        public List<string> MenuList4 { get; set; }

        public List<MusicProjectModel> MusicProjectList { get; set; }

        public MusicViewModel()
        {
            this.MenuList = new List<string>();
            MenuList.Add("发现音乐");
            MenuList.Add("博客");
            MenuList.Add("视频");
            MenuList.Add("关注");
            MenuList.Add("直播");
            MenuList.Add("私人FM");

            this.MenuList2 = new List<MenuModel>();
            MenuList2.Add(new MenuModel { Icon = "\ue6af", Name= "本地与下载" } );
            MenuList2.Add(new MenuModel { Icon = "\ue6bb", Name = "最近播放" });
            MenuList2.Add(new MenuModel { Icon = "\ue6f6", Name = "我的音乐云盘" });
            MenuList2.Add(new MenuModel { Icon = "\ue62a", Name = "我的播客" });
            MenuList2.Add(new MenuModel { Icon = "\ue65e", Name = "我的收藏" });

            this.MenuList3 = new List<string>();
            MenuList3.Add("Pthero的2021年度歌单");
            MenuList3.Add("Pthero的2020年度歌单");
            MenuList3.Add("Pthero的2019年度歌单");

            this.MenuList4 = new List<string>();
            MenuList4.Add("《东京爱情故事》");
            MenuList4.Add("吹着口哨唱着歌");
            MenuList4.Add("十年一个陈奕迅");

            this.MusicProjectList = new List<MusicProjectModel>();
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "",      ProjectName = "每日歌曲推荐" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "32万",  ProjectName = "今天从《秒钟》听起" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "200万", ProjectName = "[回忆杀]回忆8090后经典老歌金曲" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "1亿",   ProjectName = "追忆经典古装武侠流金岁月" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "45万",  ProjectName = "熟悉又陌生的日语原唱经典" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "12万",  ProjectName = "听你爱的够钟" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "200万", ProjectName = "[回忆杀]回忆8090后经典老歌金曲" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "1亿",   ProjectName = "追忆经典古装武侠流金岁月" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "45万",  ProjectName = "熟悉又陌生的日语原唱经典" });
            MusicProjectList.Add(new MusicProjectModel { CoverSource = "../Assets/Images/feng.jpg", PopularCount = "12万",  ProjectName = "听你爱的够钟" });
        }










    }
}
