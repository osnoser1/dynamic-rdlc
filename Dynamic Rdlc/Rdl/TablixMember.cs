﻿using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixMember : IElement
    {
        private readonly Group _group;
        private readonly SortExpressions _sortExpressions;
        private readonly TablixHeader _tablixHeader;

        public TablixMember()
        {
        }

        public TablixMember(Group group, SortExpressions sortExpressions, TablixHeader tablixHeader)
        {
            _group = group;
            _sortExpressions = sortExpressions;
            _tablixHeader = tablixHeader;
        }

        public Inch Size => _tablixHeader == null ? new Inch(0) : _tablixHeader.Size;

        public XElement Element => Build();

        private XElement Build()
        {
            var result = new XElement(typeof(TablixMember).GetShortName());
            ConfigureGroup(result);
            ConfigureSortExpressions(result);
            ConfigureTablixHeader(result);
            return result;
        }

        private void ConfigureGroup(XElement tablixMember)
        {
            if (_group != null)
            {
                tablixMember.Add(_group.Element);
            }
        }

        private void ConfigureSortExpressions(XElement tablixMember)
        {
            if (_sortExpressions != null)
            {
                tablixMember.Add(_sortExpressions.Element);
            }
        }

        private void ConfigureTablixHeader(XElement tablixMember)
        {
            if (_tablixHeader != null)
            {
                tablixMember.Add(_tablixHeader.Element);
            }
        }
    }
}