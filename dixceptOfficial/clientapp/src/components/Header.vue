<template>
    <div>
        <v-app-bar app dark class="bg_color">
            <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>
            <v-row justify="space-between" align="center" class="hidden-xs-only">
                <v-col cols="10" md="2">
                    <v-img :src="require('../assets/dixsept_header_label.jpg')" height="50" aspect-ratio="2" contain></v-img>
                </v-col>
                <v-col cols="2" >
                <v-row justify="end" align="center">
                    <v-col cols="3" v-for="(sns, key, index) in snsContent" :key="index" class="sns_hover">
                        <a :href="sns.url" target="_blank">
                            <v-img :src="require(`../assets/${sns.src}`)" width="30" height="30"></v-img>
                        </a>
                    </v-col>
                </v-row>
            </v-col>
            </v-row>
        </v-app-bar>
        <!-- サイドバー -->
        <v-navigation-drawer
        v-model="drawer"
        fixed
        temporary
      >
        <v-list
          nav
          dense
        >
          <v-list-item-group>
            <v-list-item to="/">
              <v-list-item-title>Home</v-list-item-title>
            </v-list-item>
            <v-list-item to="/Team">
              <v-list-item-title>Team</v-list-item-title>
            </v-list-item>
            <v-list-item to="/Player">
              <v-list-item-title>Player</v-list-item-title>
            </v-list-item>
            <v-list-item>
              <v-list-item-title>News</v-list-item-title>
            </v-list-item>
            <v-list-item>
              <v-list-item-title>MatchSchedule</v-list-item-title>
            </v-list-item>
            <v-list-item>
              <v-list-item-title>Contact</v-list-item-title>
            </v-list-item>
          </v-list-item-group>
        </v-list>
      </v-navigation-drawer>
    </div>
        
</template>


<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
    data(){
        return {
            drawer: false,
            snsContent:{
               twitter:{
                   url: "https://twitter.com/dixsept_urawa",
                   src: "twitter.png"
               }, 
               facebook:{
                   url: "https://www.facebook.com/dixsepturawa/",
                   src: "facebook.png"
               }, 
               instagram:{
                   url: "https://www.instagram.com/dixsept.official",
                   src: "instagram.png"
               }, 
            },
        }
    }
})
</script>

<style scoped>
    .sns_hover:hover{
    opacity: 0.5;/* 透過率50% */
	transition: 0.2s;/* 0.2秒アニメーション */
	-webkit-transition: 0.2s;
    }
</style>