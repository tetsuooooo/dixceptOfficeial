<template>
    <v-row>
        <v-divider></v-divider>
        <v-col cols="12" class="text-h2 text-center">Social</v-col>
        <v-row align="center" justify="center" height="500">
            <v-col cols="12" sm="11">
                <v-row align="center" justify="center">
                    <!-- facebook -->
                    <v-col cols="12" sm="3">
                        <v-row align="center" justify="center">
                            <v-col cols="11" sm="12">
                                <v-card color="grey lighten-3">
                                <v-col class="text-center"><v-icon color="blue lighten-1">fab fa-facebook</v-icon></v-col>
                                <!-- pc -->
                                <v-col class="hidden-sm-and-down">
                                    <iframe src="https://www.facebook.com/plugins/page.php?href=https%3A%2F%2Fwww.facebook.com%2Fdixsepturawa%2F&tabs=timeline&width=270&height=450&small_header=true&adapt_container_width=true&hide_cover=false&show_facepile=true&appId" width="270" height="450" style="border:none;overflow:hidden" scrolling="no" frameborder="0" allowfullscreen="true" allow="autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share"></iframe>
                                    <div id="fb-root"></div>
                                </v-col>
                                <!-- sp -->
                                 <v-col class="hidden-sm-and-up text-center">
                                     <div>
                                         <iframe src="https://www.facebook.com/plugins/page.php?href=https%3A%2F%2Fwww.facebook.com%2Fdixsepturawa%2F&tabs=timeline&width=330&height=450&small_header=true&adapt_container_width=true&hide_cover=false&show_facepile=true&appId" width="330" height="450" style="border:none;overflow:hidden" scrolling="no" frameborder="0" allowfullscreen="true" allow="autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share"></iframe>
                                        <div id="fb-root"></div>
                                     </div>
                                </v-col>
                            </v-card>
                            </v-col>
                        </v-row>
                    </v-col>
                    <!-- twitter -->
                    <v-col cols="12" sm="3">
                        <v-row align="center" justify="center">
                            <v-col cols="11" sm="12">
                                <v-card color="grey lighten-3">
                                <v-col class="text-center"><v-icon color="blue lighten-1">fab fa-twitter</v-icon></v-col>
                                <!-- pc -->
                                <v-col class="hidden-sm-and-down">
                                    <a class="twitter-timeline" data-lang="ja" data-width="290" data-height="450" data-theme="light" href="https://twitter.com/dixsept_urawa?ref_src=twsrc%5Etfw">Tweets by dixsept_urawa</a>
                                </v-col>
                                <!-- sp -->
                                <v-col class="hidden-sm-and-up text-center">
                                    <a class="twitter-timeline" data-lang="ja" data-width="330" data-height="450" data-theme="light" href="https://twitter.com/dixsept_urawa?ref_src=twsrc%5Etfw">Tweets by dixsept_urawa</a>
                                </v-col>
                            </v-card>
                            </v-col>
                        </v-row>
                    </v-col>
                    <v-col cols="12" sm="6">
                        <v-row justify="center">
                            <v-col cols="11" sm="12">
                                <a href="https://www.instagram.com/dixsept.official/?hl=ja">
                                    <v-card color="grey lighten-3" class="insta_area"></v-card>
                                </a>
                            </v-col>
                            <v-col cols="11" sm="12">
                                <a href="https://dixsept-urawa.hatenadiary.jp">
                                    <v-card color="grey lighten-3" class="blog_area"></v-card>
                                </a>
                            </v-col>
                        </v-row>
                    </v-col>
                </v-row>
            </v-col>
        </v-row>
    </v-row>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {
            //HelloWorld,
        },
    })
    export default class Home extends Vue {

    }
</script>

<style scoped>
    .insta_area {
        text-decoration: none;
        color: black;
        height: 250px;
        background-image: url("../assets/insta.png");
        background-repeat: no-repeat;
        background-size: cover;
        background-position: center;
    }

    .blog_area {
        text-decoration: none;
        color: black;
        height: 250px;
        background-image: url("../assets/blog.png");
        background-repeat: no-repeat;
        background-size: cover;
        background-position: center;
    }
    @media screen and (max-width: 480px){
      
    }
</style>
