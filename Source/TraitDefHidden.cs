﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace CultOfCthulhu
{
    public class TraitDefHidden : TraitDef
    {
        /// <summary>
        /// We override this to hide the commonality issue
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> ConfigErrors()
        {
            if (this.defName == "UnnamedDef")
            {
                yield return base.GetType() + " lacks defName. Label=" + this.label;
            }
            if (this.defName == "null")
            {
                yield return "defName cannot be the string 'null'.";
            }
            //if (!Def.AllowedDefnamesRegex.IsMatch(this.defName))
            //{
            //    yield return "defName " + this.defName + " should only contain letters, numbers, underscores, or dashes.";
            //}
            //if (this.commonality < 0.001f && this.commonalityFemale < 0.001f)
            //{
            //    yield return "TraitDef " + this.defName + " has 0 commonality.";
            //}
            if (!this.degreeDatas.Any<TraitDegreeData>())
            {
                yield return this.defName + " has no degree datas.";
            }
            //for (int i = 0; i < this.degreeDatas.Count; i++)
            //{
            //    TraitDegreeData traitDegreeData = this.degreeDatas[i];
            //    if ((from dd2 in this.degreeDatas
            //         where dd2.degree == this.degree
            //         select dd2).Count<TraitDegreeData>() > 1)
            //    {
            //        yield return ">1 datas for degree " + traitDegreeData.degree;
            //    }
            //}
            yield break;
        }
    }
}
