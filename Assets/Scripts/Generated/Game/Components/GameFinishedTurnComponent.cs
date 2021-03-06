//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Osnowa.Osnowa.Core.ECS.Initiative.FinishedTurnComponent finishedTurnComponent = new Osnowa.Osnowa.Core.ECS.Initiative.FinishedTurnComponent();

    public bool isFinishedTurn {
        get { return HasComponent(GameComponentsLookup.FinishedTurn); }
        set {
            if (value != isFinishedTurn) {
                var index = GameComponentsLookup.FinishedTurn;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : finishedTurnComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherFinishedTurn;

    public static Entitas.IMatcher<GameEntity> FinishedTurn {
        get {
            if (_matcherFinishedTurn == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FinishedTurn);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFinishedTurn = matcher;
            }

            return _matcherFinishedTurn;
        }
    }
}
