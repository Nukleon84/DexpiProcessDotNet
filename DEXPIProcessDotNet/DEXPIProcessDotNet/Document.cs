using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DEXPIProcessDotNet
{
    public class Document
    {
        public Header Header { get; set; }
        public List<DataContainer> DataContainer { get; set; } = new List<DataContainer>();
    }

    public class Header
    {
        public string Name { get; set; }
        public DateTime TimeStamp { get; set; }
        public NameAndAddress Author { get; set; }
        public NameAndAddress Organization { get; set; }

        public string PreprocessorVersion { get; set; }
        public string OriginatingSystem { get; set; }
        public string Authorization { get; set; }
        public string Documentation { get; set; }

    }

    public class NameAndAddress
    {
        public string Name { get; set; }
        public List<string> Address { get; set; } = new List<string>();

        public override string ToString()
        {
            return Name+Environment.NewLine+String.Join(Environment.NewLine, Address);
        }

    }

    public class DataContainer
    {
        public List<BaseRootObject> Items { get; set; } = new List<BaseRootObject>();

        public MaterialTemplate NewMaterialTemplate()
        {
            var item = new MaterialTemplate() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }
        public PureMaterialComponent NewPureMaterialComponent()
        {
            var item = new PureMaterialComponent() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }
        public CustomMaterialComponent NewCustomMaterialComponent()
        {
            var item = new CustomMaterialComponent() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }

        public Source NewSource()
        {
            var item = new Source() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }

        public Sink NewSink()
        {
            var item = new Sink() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }

        public ReactingChemicals NewReactingChemicals()
        {
            var item = new ReactingChemicals() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }

        public Stream NewStream()
        {
            var item = new Stream() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }

        public MaterialState NewMaterialState()
        {
            var item = new MaterialState() { Uid = Guid.NewGuid().ToString() };
            Items.Add(item);
            return item;
        }
    }

    public class BaseObject
    {
        public string Uid { get; set; }
    }

    public class BaseRootObject : BaseObject
    {

    }

    public class SingleLanguageString
    {
        public string Language { get; set; }
        public string Value { get; set; }

        public static implicit operator SingleLanguageString((string, string) t) => new SingleLanguageString { Language = t.Item1, Value = t.Item2 };

        public override string ToString()
        {
            return "["+Language + "] : " + Value;
        }
    }

    public class MultiLanguageString
    {
        public List<SingleLanguageString> SingleLanguageStrings { get; set; } = new List<SingleLanguageString>();

        public static implicit operator MultiLanguageString(SingleLanguageString[] strings) => new MultiLanguageString { SingleLanguageStrings = new List<SingleLanguageString>(strings) };
        public static implicit operator MultiLanguageString((string, string)[] strings) => new MultiLanguageString { SingleLanguageStrings = new List<SingleLanguageString>(strings.Select(s => (SingleLanguageString)s)) };
        public static implicit operator MultiLanguageString((string, string) strings) => new MultiLanguageString { SingleLanguageStrings = new List<SingleLanguageString>(new[] { (SingleLanguageString)strings }) };

        public override string ToString()
        {
            return String.Join(Environment.NewLine, SingleLanguageStrings);
        }
    }

}
