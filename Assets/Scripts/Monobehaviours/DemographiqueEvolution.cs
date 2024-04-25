using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DemographiqueEvolution : MonoBehaviour
{
    int[] years = new int[] { 1960,  1961,  1962,  1963,  1964,
   1965,  1966,  1967,  1968,
  1969,  1970,  1971,  1972,  1973,
   1974,  1975,  1976,  1977,
  1978,  1979,  1980,  1981,  1982,
   1983,  1984,  1985,  1986,
  1987,  1988,  1989,  1990,  1991,
   1992,  1993,  1994,  1995,
  1996,  1997,  1998,  1999,  2000,
   2001,  2002,  2003,  2004,
  2005,  2006,  2007,  2008,  2009,
   2010,  2011,  2012,  2013,
  2014,  2015,  2016,  2017,  2018,
   2019,  2020,  2021,  2022 };
    int[] population = new int[] {  11769774,  12081713,  12404757,  12726686,
  13044254,  13381880,  13738502,  14109755,  14490077,
   14876982,  15274351,  15677300,  16081438,
  16489452,  16902383,  17325325,  17756516,  18206472,
   18679859,  19167661, 9678444,  20208260,
  20746765,  21287381, 21817271, 22335077, 22824446,
   23279935,  23720590,  24148104,  24570814,
  24988083,  25400676,  25806777,  26201551,  26599048,
   26999093,  27397118,  27791825,  28176997,
  28554415, 28930097, 29301817, 29661270, 30033125,
  30431902, 30833022, 31232633, 31634992,
  32042877, 32464865, 32903699, 33352169, 33803527,
  34248603, 34680458, 35107264, 35528115,
  35927511, 36304408, 36688772, 37076584, 37457971 };

    [SerializeField] private TextMesh yearsText;

    [SerializeField] private TextMesh populationText;

    [SerializeField] private float time;
    [SerializeField] private float speed;


    // Start is called before the first frame update
    void Start()
    {
        yearsText.text = years[0].ToString();
        populationText.text = population[0].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
        if (time > 100)
        {
            print("passed");
        }
    }
}

