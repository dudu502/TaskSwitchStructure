﻿using BT.Composite;
using BT.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT
{
    public class BehaviourTree
    {
        private readonly RootNode m_Root = new RootNode();
        private Node.NodeResult m_TreeState = Node.NodeResult.Continue;

        public BehaviourTree()
        {

        }

        public void SetChild(Node node)
        {
            m_Root.Child = node;
        }
        public Node.NodeResult Execute()
        {
            if (m_Root.Result == Node.NodeResult.Continue)
                m_TreeState = m_Root.Execute();
            return m_TreeState;
        }

        
    }
}
