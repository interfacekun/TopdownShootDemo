//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ChangeItemCmdComp changeItemCmdComp { get { return (ChangeItemCmdComp)GetComponent(GameComponentsLookup.ChangeItemCmdComp); } }
    public bool hasChangeItemCmdComp { get { return HasComponent(GameComponentsLookup.ChangeItemCmdComp); } }

    public void AddChangeItemCmdComp(System.Collections.Generic.List<ChangeItemPair> newChangeItemList, bool newDirty) {
        var index = GameComponentsLookup.ChangeItemCmdComp;
        var component = (ChangeItemCmdComp)CreateComponent(index, typeof(ChangeItemCmdComp));
        component.ChangeItemList = newChangeItemList;
        component.Dirty = newDirty;
        AddComponent(index, component);
    }

    public void ReplaceChangeItemCmdComp(System.Collections.Generic.List<ChangeItemPair> newChangeItemList, bool newDirty) {
        var index = GameComponentsLookup.ChangeItemCmdComp;
        var component = (ChangeItemCmdComp)CreateComponent(index, typeof(ChangeItemCmdComp));
        component.ChangeItemList = newChangeItemList;
        component.Dirty = newDirty;
        ReplaceComponent(index, component);
    }

    public void RemoveChangeItemCmdComp() {
        RemoveComponent(GameComponentsLookup.ChangeItemCmdComp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherChangeItemCmdComp;

    public static Entitas.IMatcher<GameEntity> ChangeItemCmdComp {
        get {
            if (_matcherChangeItemCmdComp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ChangeItemCmdComp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChangeItemCmdComp = matcher;
            }

            return _matcherChangeItemCmdComp;
        }
    }
}