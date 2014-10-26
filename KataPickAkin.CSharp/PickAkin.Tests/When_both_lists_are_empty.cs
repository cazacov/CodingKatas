using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace PickAkin.Tests
{
    [Tags("Extreme cases")]
    [Subject(typeof(AkinPicker))]
    public class When_both_lists_are_empty : AkinPickerSpecs
    {
        Establish context = () =>
        {
            ceoList = new List<string>();
            controlList = new List<string>();
        };

        Because of = 
            () => akinList = akinPicker.PickAkinProductCodes();

        It should_return_an_empty_list =
            () => akinList.ShouldBeEmpty();
        

        
    }
}
