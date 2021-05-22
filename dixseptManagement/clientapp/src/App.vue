<template>
   <v-app>
     <v-navigation-drawer app v-model="drawer"  class="green darken-1" dark>
      <v-list-item>
        <v-list-item-title class="title">
          DixseptOfficial
        </v-list-item-title>
        <v-btn icon>
          <v-icon>mdi-chevron-left</v-icon>
        </v-btn>
      </v-list-item>
      <v-divider />
      <v-list nav>
        <v-list-item v-for="menu in menus" :key="menu.title" :to="menu.url">
          <v-list-item-icon>
            <v-icon>{{ menu.icon }}</v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title>{{ menu.title }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>

     <!-- TODO:ログイン者 ログアウト機能作成 管理者が一人しか想定しない仕様のため時間があったら作成-->
    </v-navigation-drawer>

    <v-app-bar app color="green darken-1" dark>
      <!-- アプリケーションバー -->
      <v-app-bar-nav-icon @click.stop="drawer = !drawer" />
    </v-app-bar>

    <v-content>
      <!-- メインコンテンツ読み込み -->
      <router-view />
    </v-content>

    <v-footer app>
      <!-- フッター -->
    </v-footer>
  </v-app>　
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'App',

  data(){
    return{
        drawer: true,
        menus: [
          { title: 'Player', icon: 'fas fa-user', url: '/player' },
          { title: 'Schedule', icon: 'fas fa-calendar-week', url: '/schedule' },
          { title: 'Emblem', icon: 'far fa-image', url: '/team' },
          { title: 'Result', icon: 'far fa-futbol', url: '/result' }
        ]
    }
  }
});
</script>
