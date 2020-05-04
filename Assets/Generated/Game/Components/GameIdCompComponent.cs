//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Base.IdComp idComp { get { return (Components.Base.IdComp)GetComponent(GameComponentsLookup.IdComp); } }
    public bool hasIdComp { get { return HasComponent(GameComponentsLookup.IdComp); } }

    public void AddIdComp(int newValue) {
        var index = GameComponentsLookup.IdComp;
        var component = (Components.Base.IdComp)CreateComponent(index, typeof(Components.Base.IdComp));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceIdComp(int newValue) {
        var index = GameComponentsLookup.IdComp;
        var component = (Components.Base.IdComp)CreateComponent(index, typeof(Components.Base.IdComp));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveIdComp() {
        RemoveComponent(GameComponentsLookup.IdComp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity : IIdCompEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherIdComp;

    public static Entitas.IMatcher<GameEntity> IdComp {
        get {
            if (_matcherIdComp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.IdComp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIdComp = matcher;
            }

            return _matcherIdComp;
        }
    }
}
