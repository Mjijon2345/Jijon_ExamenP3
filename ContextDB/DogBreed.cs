using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jijon_ExamenP3.ContextDB
{
    public partial class DogBreed : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string breedName;
        [ObservableProperty]
        public string imageUrl;
    } 
    
}
