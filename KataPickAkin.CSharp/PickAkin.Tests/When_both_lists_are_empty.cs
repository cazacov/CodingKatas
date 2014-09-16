using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace PickAkin.Tests
{
    [Subject(typeof(AkinPicker), "Extreme cases")]
    public class When_both_lists_are_empty : AkinPickerSpecs
    {
        Establish context = () =>
        {
            akinPicker = new AkinPicker();
            ceoList = new List<string>();
            controlList = new List<string>();
        };

        Because of = 
            () => akinList = akinPicker.PickAkinProductCodes();

        private It should_return_an_empty_list =
            () => akinList.Any().ShouldBeFalse();
    }
}
