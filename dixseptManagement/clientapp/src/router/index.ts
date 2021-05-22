import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import Home from '../views/Home.vue'
import Player from '../views/Player.vue'
import Schedule from '../views/Schedule.vue'
import Team from '../views/Team.vue'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/player',
    component: Player
  },
  {
    path: '/schedule',
    component: Schedule
  },
  {
    path: '/Team',
    component: Team
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
