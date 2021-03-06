﻿using System;
namespace Pigeon.Actor
{
    public interface IActorRefFactory
    {
        LocalActorRef ActorOf(Props props, string name = null);
        LocalActorRef ActorOf<TActor>(string name = null);
        ActorSelection ActorSelection(ActorPath actorPath);
        ActorSelection ActorSelection(string actorPath);
    }
}