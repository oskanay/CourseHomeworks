using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Hw5
{
    class MyDictionary<K,V>
    {
        K[] _arrayKey;   //class'ı newlediğimizde oluşturmamız gerekiyor.(0 elemanlı bile olsa)
        V[] _arrayValue; //Çünkü bu diziyi Add metotu içine ekleyeceğiz.
        K[] _tempArrayKey;
        V[] _tempArrayValue;
        public MyDictionary() //constructer,class'ı newlediğimizde çalışan kısımdır.Ekleyebilmemiz için  newlememiz gerekir.
        {
            _arrayKey = new K[0];
            _arrayValue = new V[0];

        }
        public void Add(K item, V item2)
        {
            _tempArrayKey = _arrayKey;
            _tempArrayValue = _arrayValue;
            _arrayKey = new K[_arrayKey.Length + 1];  //0 elemanlı olduğu için önce eleman sayısını bir arttırdık,ve içi boş yeni bir dizi oluştu
            _arrayValue = new V[_arrayValue.Length + 1]; //0 elemanlı olduğu için önce eleman sayısını bir arttırdık,ve içi boş yeni bir dizi oluştu.

            for (int i = 0; i < _tempArrayKey.Length; i++) //_tempArrayKey'de olan geçici elemanları item'e atadık.
            {
                _arrayKey[i] = _tempArrayKey[i];
            }
            for (int j = 0; j < _tempArrayValue.Length; j++)//_temprArrayKey'de olan geçici elemanları item2'ye atadık.
            {
                _arrayValue[j] = _tempArrayValue[j];
            }
            _arrayKey[_arrayKey.Length - 1] = item; //_temprArrayKey'de olan geçici elemanları item2'ye atadıktan sonra eklenen son elemanı da 
                                                    //burada item'a ekliyoruz

            _arrayValue[_arrayValue.Length - 1] = item2; //_temprArrayKey'de olan geçici elemanları item2'ye atadıktan sonra eklenen son elemanı da 
                                                         //burada item'a ekliyoruz
        }
        public int Count
        {
            get { return _arrayKey.Length; }
        }
        public K[] Key
        {
            get { return _arrayKey; }
        }
        public V[] Value
        {
            get { return _arrayValue; }
        }
    }
}
