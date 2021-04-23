<template>
    <div>
        <header>
            <v-app-bar app dark class="bg_color">
                <v-app-bar-nav-icon @click="drawer = true" class="d-block d-sm-none"></v-app-bar-nav-icon>
                <v-row>
                    <v-col cols="2">
                        <v-img :src="require('../assets/dixsept_header_label.jpg')" height="50" aspect-ratio="2" contain></v-img>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col cols="12" class="padding_none">
                        <v-row justify="center" align-content="center" class="bg_color_black">
                            <v-col cols="5" class="padding_none text-right">
                                <v-tabs class="sample">
                                    <v-tab>Home</v-tab>
                                    <v-tab>Team</v-tab>
                                    <v-tab>Player</v-tab>
                                </v-tabs>
                            </v-col>
                            <v-col cols="1" class="padding_none bg_color_black">
                                <v-col cols="12" class="padding_none logo_img"></v-col>
                            </v-col>
                            <v-col cols="5" class="padding_none">
                                <v-tabs>
                                    <v-tab>News</v-tab>
                                    <v-tab>Schedule</v-tab>
                                    <v-tab>Contact</v-tab>
                                    <v-spacer></v-spacer>
                                </v-tabs>
                            </v-col>
                        </v-row>
                    </v-col>
                </v-row>
            </v-app-bar>
        </header>
        <!-- サイドバー -->
        <v-navigation-drawer v-model="drawer"
                             fixed
                             temporary>
            <v-list nav
                    dense>
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
                    <v-list-item to="/News">
                        <v-list-item-title>News</v-list-item-title>
                    </v-list-item>
                    <v-list-item to="/Schedule">
                        <v-list-item-title>MatchSchedule</v-list-item-title>
                    </v-list-item>
                    <v-list-item to="/Contact">
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
        data() {
            return {
                drawer: false,
                snsContent: {
                    twitter: {
                        url: "https://twitter.com/dixsept_urawa",
                        src: "twitter.png"
                    },
                    facebook: {
                        url: "https://www.facebook.com/dixsepturawa/",
                        src: "facebook.png"
                    },
                    instagram: {
                        url: "https://www.instagram.com/dixsept.official",
                        src: "instagram.png"
                    },
                },
            }
        }
    })
</script>

<style>

    .sns_hover:hover {
        opacity: 0.5; /* 透過率50% */
        transition: 0.2s; /* 0.2秒アニメーション */
        -webkit-transition: 0.2s;
    }

    .header_area {
        height: 200px;
    }
    /* ヘッダを二段にするために無理やりcssを変更しています */
    /* TODO: 正規の方法があったら変更する */
    .v-toolbar__content, .v-toolbar__extension {
        display: block !important;
        padding: none !important;
    }
    .v-slide-group__content{
        justify-content: flex-end !important;
    }
    .v-tab{
        width: 10vw;
    }
    .theme--dark{
        background-color: black !important;
    }
    /* ヘッダーロゴ設定 */
    .logo_img{
        position: absolute;
    }
    .logo_img::after{
        content: '';
        display: inline-block;
        position: relative;
        width: 10vw;
        height: 18vh;
        top: -7vh;
        left: 0px;
        background-image: url("../assets/dixsept_header_logo.png");
        background-size: contain;
    }
</style>