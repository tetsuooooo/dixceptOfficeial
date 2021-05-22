import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import Home from '../views/Home.vue'
import Team from '../views/Team.vue'
import Player from '../views/Player.vue'
import News from '../views/News.vue'
import NewsDetail from '../views/NewsDetail.vue'
import MatchResult from '../views/MatchResult.vue'
import Training from '../views/Training.vue'
import Schedule from '../views/Schedule.vue'
import Contact from '../views/Contact.vue'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
    {
        path: '/',
        component: Home
    },
    {
        path: '/Team',
        component: Team
    },
    {
        path: '/Player',
        component: Player
    },
    {
        path: '/News',
        component: News
    },
    {
        path: '/News/:id',
        name: 'news-detail',
        component: NewsDetail,
        props: true,
    },
    {
        path: '/MatchResult/:id',
        name: 'match-result',
        component: MatchResult,
        props: true
    },
    {
        path: '/Training/:id',
        name: 'training',
        component: Training,
        props: true
    },
    {
        path: '/Schedule',
        component: Schedule
    },
    {
        path: '/Contact',
        component: Contact,
    },
    {
        // ユーザーがクエリ改変してきた場合は全部ホームページに行くようにする
        path: '*',
        redirect: '/'
    }
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes,
    scrollBehavior(to, from, savedPosition){
        return new Promise(resolve=>{
            this.app.$root.$on('scroll', () => {
                let position = {x:0, y:0}
                 // 遷移前のページのスクロールの情報があった場合には遷移前のスクロールポジションに戻る
                if(savedPosition){
                    position = savedPosition;
                }
                return resolve(position)
            })
        })
    }
})

export default router
